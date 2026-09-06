using Alumno.Abstractions.DTO;
using Alumnos.Data.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AlumnoEntity = Alumnos.Data.EF.Alumno;

namespace Alumnos.Data.Repositories
{
    public class AlumnoRepository(AlumnosDBContext _context)
    {
        public async Task <List<AlumnoDTO>> GetAllAlumnosAsync()
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

        public async Task<AlumnoDTO> CreateAlumnoAsync(AlumnoDTO alumno)
        {
            var newAlumno = new AlumnoEntity
            {
                Name = alumno.Name,
                Surname = alumno.Surname,
                Age = alumno.Age,
            };

            _context.Alumnos.Add(newAlumno);

            await _context.SaveChangesAsync();

            return new AlumnoDTO
            {
                Name = newAlumno.Name,
                Surname = newAlumno.Surname,
                Age = newAlumno.Age,
            };
        }
    }
}
