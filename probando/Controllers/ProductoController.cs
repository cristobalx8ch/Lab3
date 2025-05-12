using Microsoft.AspNetCore.Mvc;
using probando.Models.domain;

namespace probando.Controllers
{

    //este controlador permite listar crear y ver detalles  de productos
    public class ProductoController : Controller
    {
        // se crea una lista estatica de producto
        private static List<Producto> productos = new List<Producto>();


        //accion que maneja la solicitud get para mostrar la lista de producto 
        public IActionResult Index()
        {
            // devuelve la listay muestra  todo los producto
            return View(productos);
        }

        //accion get que maneja para mostrar la formulario de creacion de un nuevo producto 
        public IActionResult Create()
        {
            // devuelve la vista para crear nuevo producto
            return View();
        }


        // accion post para recibir datos del nuevo producto y agregarlo a la lista 
        [HttpPost]
        public IActionResult Create(Producto p)
        {
            // el modelo recibido es valido 
            if (ModelState.IsValid)
            {
                // agregar el nuevo producto a la lista 
                productos.Add(p);
                // redirige a la accion index para mostrar la lista de producto  
                return RedirectToAction("Index");
            }
            // si no es valido  vuelve a mostrar la vista de creacion 
            return View(productos);
        }

        //accion que muestra los detalles de un producto espesifico identificado por su codigo de barra
        public IActionResult Details(string codigo)
        {
            // recorre la lista de producto para encontrar uno cuyo de barra coincida 
            foreach (var producto in productos)
            {
                // encuentra el producto con el codigo de barra dado
                if (producto.CodigoDeBarra == codigo)
                {
                    //retorna la vista pcon los detalles del producto encontrado 
                    return View(producto);
                }
            }
            // si no  se encuentra ningun producto con este codigo  retorna un error
            return NotFound();
        }

        public IActionResult Edit(string codigo)
        {
            foreach (var p in productos)
            {
                if (p.CodigoDeBarra == codigo)
                {
                    return View(p);
                }
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(Producto p)
        {
            for (int i = 0; i < productos.Count; i++)
            {
                if (productos[i].CodigoDeBarra == p.CodigoDeBarra)
                {
                    if (ModelState.IsValid)
                    {
                        productos[i].Nombre = p.Nombre;
                        productos[i].Precio = p.Precio;
                        productos[i].CantidadDisponible = p.CantidadDisponible;
                        productos[i].Estado = p.Estado;

                        return RedirectToAction("Index");
                    }
                    return View(p);
                }
            }
            return NotFound();
        }

        public IActionResult Delete(string codigo)
        {
            foreach (var p in productos)
            {
                if (p.CodigoDeBarra == codigo)
                {
                    return View(p);
                }
            }
            return NotFound();
        }


        [HttpPost]
        public IActionResult DeleteConfirmed(string codigo)
        {
            for (int i = 0; i < productos.Count; i++)
            {
                if (productos[i].CodigoDeBarra == codigo)
                {
                    productos.RemoveAt(i);
                    break;
                }
            }
            return RedirectToAction("Index");
        }
    }
}



