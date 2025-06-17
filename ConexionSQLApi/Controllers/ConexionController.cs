using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace ConexionSQLApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConexionController : ControllerBase
    {
        // ⚠️ Reemplaza esta cadena con la conexión correcta a tu SQL Server
        private readonly string cadena = "Server=LEONARDOMTZ\\SQLEXPRESS;Database=XamarinDB;Trusted_Connection=True;";

        [HttpGet("test")]
        public IActionResult ProbarConexion()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    return Ok("Conexión exitosa");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error al conectar: " + ex.Message);
            }
        }
    }
}
