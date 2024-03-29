﻿using EFCORE_10.Entites;

namespace EFCORE_010.Entites
{
    public class Section
    {
        public int Id { get; set; }
        public string SectionName { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int? InstructorId { get; set; }
        public Instructor? Instructor { get; set; }

        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        public TimeSlot TimeSlot { get; set; }
        public ICollection<Particpant> Particpant { get; set; } = new List<Particpant>();
    }

    public class TimeSlot
    {
        public TimeSpan StarTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public override string ToString()
        {
            return $"{StarTime.ToString("hh\\:mm")} - {EndTime.ToString("hh\\:mm")}";
        }
    }
}