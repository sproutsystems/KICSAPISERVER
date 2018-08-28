using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Sessionimportattemptunmatchedmovie
    {
        public int SessionImportAttemptUnmatchedMovieId { get; set; }
        public int SessionImportAttemptId { get; set; }
        public string Title { get; set; }

        public Sessionimportattempt SessionImportAttempt { get; set; }
    }
}
