using System;
using System.Collections.Generic;
using UniPlanner.DAL;
using UniPlanner.DBContext;
using UniPlanner.DTO;

namespace UniPlanner.BLL
{
    public class Management
    {
        #region Constructors

        public Management()
        {
            _lessonRepository = new LessonDal(new BaseContext());
        }

        public Management(BaseContext context)
        {
            _lessonRepository = new LessonDal(context);
        }

        #endregion
        #region Private Fields

        private LessonDal _lessonRepository;

        #endregion
        public IEnumerable<LessonDto> GetLessonsForStudentOnDay(Guid studentId, DayOfWeek day)
        {
            throw new NotImplementedException();
            //_lessonRepository.FindBy(x => x.S)
        }
    }
}
