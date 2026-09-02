using System;
using System.Collections.Generic;

namespace Alumnos.Data.EF;

public partial class Alumno
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public int Age { get; set; }
}
