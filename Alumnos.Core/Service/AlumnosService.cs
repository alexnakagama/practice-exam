using Alumno.Abstractions.DTO;
using Alumno.Abstractions.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos.Core.Service
{
    public class AlumnosService(IAlumnosRepository _repository)
    {
        public async Task<List<AlumnoDTO>> GetAllAlumnosAsync()
        {
            var result = await _repository.GetAllAlumnosAsync();

            return null;
        }
    }
}
