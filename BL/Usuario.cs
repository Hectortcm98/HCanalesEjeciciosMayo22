using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Usuario
    {
        public static(bool, string, ML.Usuario, Exception) Add (ML.Usuario usuario)
        {
			try
			{
				using (DL.HcanalesVistasContext contex= new DL.HcanalesVistasContext())
				{
					var query = contex.Database.ExecuteSqlRaw("EXEC AddUsuario @Nombre, @Email, @Telefono, @Empresa",
                        
                        new SqlParameter("@Nombre", usuario.Nombre),
						new SqlParameter("@Email", usuario.Email),
						new SqlParameter("@Telefono", usuario.Telefono),
						new SqlParameter("@Empresa", usuario.Empresa));

					if(query > 0)
					{
						return (true, null, usuario, null);
					}
					else
					{
						return(false, null, usuario, null);
					}
				}
			}
			catch (Exception ex)
			{

				return(false, null,null, ex);
			}
        }

    }
}
