using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Usuario2
    {
        public static (bool, string, ML.Usuario2, Exception? exception) Add(ML.Usuario2 usuario)
        {
            try
            {
                using (DL.HcanalesVistasContext context = new DL.HcanalesVistasContext())
                {
                    var query = context.Database.ExecuteSqlRaw("EXEC AddUsuario2 @Nombre, @ApellidoPaterno, @ApellidoMaterno, @FechaNacimiento, @EntidadNacimiento, @Curp, @Rfc, @Telefono, @Correo, @EstadoCivil, @Genero",
                        new SqlParameter("@Nombre", usuario.Nombre),
                        new SqlParameter("@ApellidoPaterno", usuario.ApellidoPaterno),
                        new SqlParameter("@ApellidoMaterno", usuario.ApellidoMaterno),
                        new SqlParameter("@FechaNacimiento", usuario.FechaNacimiento),
                        new SqlParameter("@EntidadNacimiento", usuario.EntidadNacimiento),
                        new SqlParameter("@Curp", usuario.Curp),
                        new SqlParameter("@Rfc", usuario.Rfc),
                        new SqlParameter("@Telefono", usuario.Telefono),
                        new SqlParameter("@Correo", usuario.Correo),
                        new SqlParameter("@EstadoCivil", usuario.EstadoCivil),
                        new SqlParameter("@Genero", usuario.Genero));

                    if (query > 0)
                    {
                        return (true, null, usuario, null);
                    }
                    else
                    {
                        return (false, null, usuario, null);
                    }
                }
            }
            catch (Exception ex)
            {
                return (false, null, null, ex);
            }
        }

    }
}
