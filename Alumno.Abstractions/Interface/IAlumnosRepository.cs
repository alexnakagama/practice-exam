using Alumno.Abstractions.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno.Abstractions.Interface
{
    public interface IAlumnosRepository
    {
        Task<AlumnoDTO> CreateAlumnoAsync(AlumnoDTO alumno);
        Task<List<AlumnoDTO>> GetAllAlumnosAsync();
    }
}
