using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class LibroController : ControllerBase
    {

        Dictionary<int, string> libros = new Dictionary<int, string> {
            { 1, "Orgullo y Prejuicio"},
            { 2, "Cartas de amor a los muertos"},
            { 3, "Harry Potter y el Prisionero de Azkaban"}
          };


        [HttpGet]
        public String RetrieveAllBooks() {

         /* Dictionary<int, string> libros = new Dictionary<int, string> {
            { 1, "Orgullo y Prejuicio"},
            { 2, "Cartas de amor a los muertos"},
            { 3, "Harry Potter y el Prisionero de Azkaban"} 
          };*/

            // Extraer solo los nombres de los libros
            var nombresLibros = libros.Values.ToList();

            // Unir los nombres de los libros en una cadena separada por coma
            string librosSeparadosPorComa = string.Join(", ", nombresLibros);

            return librosSeparadosPorComa;

        }

        [HttpGet("{id}")]
        public string RetrieveBook(int id)
        {
            if (libros.ContainsKey(id))
            {
                return libros[id];
            }
            else
            {
                return "Libro no encontrado, pruebe con otro número";
            }
        }



    }
}
