using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UniPlanner.DBContext;
using UniPlanner.DTO;
using UniPlanner.Entities;

namespace UniPlanner.DAL
{
    public class LessonDal
    {
        protected readonly DbContext _entities;
        protected readonly IDbSet<Lesson> _dbset;

        public LessonDal(BaseContext context)
        {
            _entities = context;
            _dbset = context.Set<Lesson>();
        }
        public virtual IEnumerable<LessonDto> GetAll()
        {
            return _dbset.Where(T => T.IsActive).Select(x => new LessonDto()
            {
                Id = x.Id,
                Sequence = x.Sequence,
                StudentGroup = x.StudentGroup,
                Room = x.Room,
                LessonType = x.LessonType,
                WeekType = x.WeekType,
                Course = x.Course,
                Semester = x.Semester,
                Day = x.Day,
                ActualYear = x.ActualYear,
                IsActive = x.IsActive
            }).AsEnumerable();
        }

        public LessonDto GetById(Guid id)
        {
            var x = _dbset.Find(id);
            var lessonDto = new LessonDto()
            {
                Id = x.Id,
                Sequence = x.Sequence,
                StudentGroup = x.StudentGroup,
                Room = x.Room,
                LessonType = x.LessonType,
                WeekType = x.WeekType,
                Course = x.Course,
                Semester = x.Semester,
                Day = x.Day,
                ActualYear = x.ActualYear,
                IsActive = x.IsActive
            };
            return lessonDto;
        }

        public IEnumerable<LessonDto> FindBy(System.Linq.Expressions.Expression<Func<Lesson, bool>> predicate)
        {
            return _dbset.Where(predicate).Select(x => new LessonDto()
            {
                Id = x.Id,
                Sequence = x.Sequence,
                StudentGroup = x.StudentGroup,
                Room = x.Room,
                LessonType = x.LessonType,
                WeekType = x.WeekType,
                Course = x.Course,
                Semester = x.Semester,
                Day = x.Day,
                ActualYear = x.ActualYear,
                IsActive = x.IsActive
            }).AsEnumerable();
        }

        public virtual void Add(LessonDto entity)
        {
            Lesson lesson = new Lesson()
            {
                Id = entity.Id,
                Sequence = entity.Sequence,
                StudentGroup = entity.StudentGroup,
                Room = entity.Room,
                LessonType = entity.LessonType,
                WeekType = entity.WeekType,
                Course = entity.Course,
                Semester = entity.Semester,
                Day = entity.Day,
                ActualYear = entity.ActualYear,
                IsActive = entity.IsActive
            };
            _dbset.Add(lesson);
        }

        public virtual void Delete(LessonDto entity)
        {
            Lesson lesson = new Lesson()
            {
                Id = entity.Id,
                Sequence = entity.Sequence,
                StudentGroup = entity.StudentGroup,
                Room = entity.Room,
                LessonType = entity.LessonType,
                WeekType = entity.WeekType,
                Course = entity.Course,
                Semester = entity.Semester,
                Day = entity.Day,
                ActualYear = entity.ActualYear,
                IsActive = entity.IsActive
            };
            _dbset.Remove(lesson);
        }

        public virtual void Edit(LessonDto entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;//??
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }
    }
}
