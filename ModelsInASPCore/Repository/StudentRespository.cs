using ModelsInASPCore.Models;

namespace ModelsInASPCore.Repository
{
    public class StudentRespository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }

        public StudentModel getStudenetById(int id)
        {
            return DataSource().Where(x => x.rollNo == id).FirstOrDefault();

        }
        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {
                new StudentModel { rollNo = 1, Name = "Mujahid", Gender = "male", Standard = 12 },
                new StudentModel { rollNo = 2, Name = "Hamza", Gender = "male", Standard = 8 },
                new StudentModel { rollNo = 3, Name = "Abcd", Gender = "female", Standard = 11 },
                new StudentModel { rollNo = 4, Name = "Zubair", Gender = "male", Standard = 13 },
                new StudentModel { rollNo = 5, Name = "Efgh", Gender = "female", Standard = 9 },
            };
        }
    }
}
