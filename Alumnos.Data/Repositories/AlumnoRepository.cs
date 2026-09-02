using Alumno.Abstractions.DTO;
using Alumnos.Data.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos.Data.Repositories
{
    public class AlumnoRepository(AlumnosDBContext _context)
    {
        public async Task <List<AlumnoDTO>> GetAllAlumnos()
        {
            var alumnos = await (
                from a in _context.Alumnos
                select new AlumnoDTO
                {
                    Name = a.Name,
                    Surname = a.Surname,
                    Age = a.Age,
                }
                ).ToListAsync();

            return alumnos;
        }
    }
}
