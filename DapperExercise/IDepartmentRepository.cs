using System;
using System.Collections.Generic;

namespace DapperExercise
{
	public interface IDepartmentRepository
	{
		IEnumerable<Department> GetAllDepartments();
	}
}

