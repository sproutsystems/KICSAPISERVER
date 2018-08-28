using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KICSAPI.Models
{
    public class CompanyDTO
    {
        public Guid CompanyId { get; set; }
        public string NameForDisplay { get; set; }
        public string WebsiteURL { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
    }

    public class CompanyNameDTO
    {
        public Guid CompanyId { get; set; }
        public string NameForDisplay { get; set; }
    }

    public class CompanyCinemasDTO
    {
        public Guid CinemaId { get; set; }
        public string Name { get; set; }
    }

    public class CinemaNameDTO
    {
        public Guid CinemaId { get; set; }
        public string Name { get; set; }
    }

    public class SessionsByCinemaDTO
    {
        public long SessionId { get; set; }
        public Guid CinemaId { get; set; }
        public DateTime SessionDateTime { get; set; }
        public String CinemaName { get; set; }
        public String ScreenName { get; set; }
        public String MovieTitle { get; set; }
        public String PriceGroup { get; set; }
        public String PosterURL { get; set; }
        public String RunningTimeInMin { get; set; }
        public String RatingName { get; set; }

    }


    public class LoginDTO
    {
        public string loginType { get; set; }
        public string username { get; set; }
        public bool status { get; set; }
        public Guid cmsUserId { get; set; }

    }

    public class LogoutDTO
    {
        public string loginType { get; set; }
        public string username { get; set; }
        public bool status { get; set; }

    }

    public class KtixPosTerminalDTO
    {
        public Guid KTixPosTerminalId { get; set; }
        public int KTixPosUseTypeId { get; set; }
        public string KTixDescription { get; set; }
        public Guid companyId { get; set; }
        public Guid cinemaId { get; set; }
        public string DeviceName { get; set; }
        public string DeviceId { get; set; }
        public string DeviceModel { get; set; }
        public string IPAddress { get; set; }
        public string APIEndPoint { get; set; }


    }

    public class KtixPosTypeNameDTO
    {
        public String KTixPosTypeName { get; set; }

    }
}
