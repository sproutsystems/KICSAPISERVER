using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Sessionimportattempt
    {
        public Sessionimportattempt()
        {
            Sessionimportattemptimportedsession = new HashSet<Sessionimportattemptimportedsession>();
            Sessionimportattemptlog = new HashSet<Sessionimportattemptlog>();
            Sessionimportattemptunmatchedmovie = new HashSet<Sessionimportattemptunmatchedmovie>();
        }

        public int SessionImportAttemptId { get; set; }
        public Guid CinemaId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Text { get; set; }
        public string EmailAddress { get; set; }
        public int NumberOfSessions { get; set; }
        public int NumberOfMoviesFound { get; set; }
        public int NumberOfMoviesSkipped { get; set; }
        public int NumberOfSessionsUpdated { get; set; }
        public int NumberOfSessionsInserted { get; set; }
        public string ErrorText { get; set; }
        public bool? IsActive { get; set; }
        public bool IsCompleted { get; set; }
        public string UnmatchedMovieList { get; set; }

        public Cinema Cinema { get; set; }
        public ICollection<Sessionimportattemptimportedsession> Sessionimportattemptimportedsession { get; set; }
        public ICollection<Sessionimportattemptlog> Sessionimportattemptlog { get; set; }
        public ICollection<Sessionimportattemptunmatchedmovie> Sessionimportattemptunmatchedmovie { get; set; }
    }
}
