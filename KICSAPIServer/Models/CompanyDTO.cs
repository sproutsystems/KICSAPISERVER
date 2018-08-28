using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KICSAPIServer.Models
{

    public class UserLoginDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }


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
        public Guid KTixSettingId { get; set; }
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
        public string TimeZoneLocationID { get; set; }
        public string LogoUrl { get; set; }
        public string Address { get; set; }

    }

    public class CinemaPaymentGatewayDTO
    {
        public Guid CinemaId { get; set; }
        public string PaymentGatewayName { get; set; }
        public string Credential1 { get; set; }
        public string Credential2 { get; set; }
        public string Credential3 { get; set; }
        public string Credential4 { get; set; }
        public string Credential5 { get; set; }
        public bool? IsTesting { get; set; }
        public string GatewayURL { get; set; }
    }


    public class LoginDTO
    {
        public string LoginType { get; set; }
        public string Username { get; set; }
        public bool Status { get; set; }
        public Guid CmsUserId { get; set; }
        public string Key { get; set; }

    }

    public class LogoutDTO
    {
        public string LoginType { get; set; }
        public string Username { get; set; }
        public bool Status { get; set; }

    }

    public class KtixPosTerminalDTO
    {
        public Guid KTixPosTerminalId { get; set; }
        public int KTixPosUseTypeId { get; set; }
        public string KTixDescription { get; set; }
        public Guid CompanyId { get; set; }
        public Guid CinemaId { get; set; }
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

    public class SessionsByCinemaDTO
    {
        public long SessionId { get; set; }
        public Guid CinemaId { get; set; }
        public DateTime SessionDateTime { get; set; }
        public String DayOfWeek { get; set; }
        public String CinemaName { get; set; }
        public String ScreenName { get; set; }
        public String MovieTitle { get; set; }
        public Guid KTixPriceGroupId { get; set; }
        public String PriceGroup { get; set; }
        public String PosterURL { get; set; }
        public String RunningTimeInMin { get; set; }
        public String RatingName { get; set; }
        public String Codes { get; set; }
        public bool IsSoldOut { get; set; }
        public bool IsCancelled { get; set; }
    }

    public class TicketsBySessionDTO
    {
        public long KTixPriceGroupSaleItemId { get; set; }
        public Guid KTixSaleItemId { get; set; }
        public int DisplayOrder { get; set; }
        public decimal Price { get; set; }
        public String KTixSaleItemName { get; set; }
        public Boolean IsAvaliable { get; set; }
        public Boolean IsSoldout { get; set; }
    }

    public class ProductsBySessionDTO
    {
        public long KTixPriceGroupSaleItemId { get; set; }
        public Guid KTixSaleItemId { get; set; }
        public int DisplayOrder { get; set; }
        public decimal Price { get; set; }
        public String KTixSaleItemName { get; set; }
        public Boolean IsAvaliable { get; set; }
        public Boolean IsSoldout { get; set; }
    }

    public class KioskCategoriesDTO
    {
        public Guid KTixKioskCategoryId { get; set; }
        public String Name { get; set; }
        public int DisplayOrder { get; set; }
        public String IconURL { get; set; }
        public String BgCode { get; set; }
        public bool IsAvaliable { get; set; }
        public String IconURLDisabled { get; set; }
    }


    public class KioskCategoryProductsDTO
    {
        public Guid KTixKioskSaleItemId { get; set; }
        public String Name { get; set; }
        public decimal DefaultPrice { get; set; }
        public int MaxQuantity { get; set; }
        public int DisplayOrder { get; set; }
        public Boolean IsAvaliable { get; set; }
        public Boolean IsSoldOut { get; set; }
    }

    public class DependantCategoriesDTO
    {
        public Guid KTixItemGroupId { get; set; }
        public String Name { get; set; }
        public int DisplayOrder { get; set; }
        public String IconURL { get; set; }
        public String BgCode { get; set; }
        public bool IsAvaliable { get; set; }
    }

    public class DependantCategoryProductsDTO
    {
        public Guid KTixSaleItemId { get; set; }
        public String Name { get; set; }
        public decimal DefaultPrice { get; set; }
    }

    public class AddtoCartDTO
    {
        public int? KTixTransactionCartId { get; set; }
        public int? KTixPriceGroupSaleItemId { get; set; }
        public int? KTixPriceGroupComboItemId { get; set; }
        public Guid? KTixVoucherId { get; set; }
        public int Quantity { get; set; }
        public Guid? KTixKioskSaleItemId { get; set; }
    }


    public class AddTicketProductToCartDTO
    {
        public int KTixTransactionCartId { get; set; }
        public int KTixPriceGroupSaleItemId { get; set; }
        public Guid KTixPriceGroupId { get; set; }
        public long SessionId { get; set; }
        public Guid KTixPosTerminalId { get; set; }
        public Guid CMSUserId { get; set; }

    }

    public class RemoveTicketProductToCartDTO
    {
        public int KTixTransactionCartId { get; set; }
        public int KTixPriceGroupSaleItemId { get; set; }
        public long SessionId { get; set; }

    }

    public class AddKioskProductToCartDTO
    {
        public int KTixTransactionCartId { get; set; }
        public Guid KTixKioskSaleItemId { get; set; }
        public Guid KTixPosTerminalId { get; set; }
        public Guid CMSUserId { get; set; }

    }

    public class RemoveKioskProductToCartDTO
    {
        public int KTixTransactionCartId { get; set; }
        public Guid KTixKioskSaleItemId { get; set; }
    }

    public class ItemsInCartDTO
    {
        public int? KTixPriceGroupSaleItemId { get; set; }
        public bool IsTicket { get; set; }
        public bool IsProduct { get; set; }
        public Guid? KTixKioskSaleItemId { get; set; }
        public bool IsKioskItem { get; set; }
        public string FullItemString { get; set; }
        public int Quantity { get; set; }
        public string Price { get; set; }
        public string Subtotal { get; set; }

    }
    
    public class ProcessDTO
    {
        public long CartId { get; set; }
        public Guid KTixSettingId { get; set; }
        public Guid CinemaId { get; set; }
    }


    public class CommitDTO
    {
        public Guid KtixMasterTransactionId  { get; set; }
        public Guid CinemaId { get; set; }
        public bool IsEftpos { get; set; }
        public bool IsCash { get; set; }
        public bool IsGiftCard { get; set; }
        public decimal CreditCardAmount { get; set; }
        public decimal MoneyRecieved { get; set; }
        public decimal MoneyReturned { get; set; }
        public string GiftCardNumber { get; set; }
    }



    public class UpdatedCartDTO
    {
        public long CartId { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
        public string CartCreateDateTime { get; set; }
        public string CartExpiryDateTime { get; set; }
    }

    public class MyMasterTransactionDTO
    {
        public Guid KtixMasterTransactionId { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
        public Boolean IsCommited { get; set; }
        public string ReferenceNumber { get; set; }
        public Guid? KTixBookingId { get; set; }
        public string KTixBookingNumber { get; set; }
        public Guid? KTixKioskOrderId { get; set; }
        public string KTixOrderNumber { get; set; }
        public long? CartId { get; set; }

    }


    public class ThisMasterTransactionDTO
    {
        public Guid KtixMasterTransactionId { get; set; }
        public string Message { get; set; }
        public Boolean IsCommited { get; set; }
        public string ReferenceNumber { get; set; }
        public string CartId { get; set; }
        public string BookingDateTime { get; set; }
        public string TotalCost { get; set; }
        public string SessionDateTime { get; set; }
        public string BookingItemsSummary { get; set; }
        public string PaymentType { get; set; }
        public List<ItemsInCartDTO> ItemsInCartDTO { get; set; }

    }

    public class ReceiptDataDTO
    {
        public string CinemaLogoURL { get; set; }
        public string BookingDatetime { get; set; }
        public string CinmeaName { get; set; }
        public string MovieDetails { get; set; }
        public string SessionDatetime { get; set; }
        public string ReferenceNumber { get; set; }
        public string BarcodeHandler { get; set; }
        public string BookingTicketListAsString { get; set; }
        public string BookingTotalCost { get; set; }
        public string KioskProductListAsString { get; set; }
        public string KiostTotalCost { get; set; }
        public string TotalTramsactionCost { get; set; }
        public string PaymentMethod { get; set; }


    }

    public class TicketDataDTO
    {
        public string CinemaLogoURL { get; set; }
        public string BookingDatetime { get; set; }
        public string CinmeaName { get; set; }
        public string MovieDetails { get; set; }
        public string SessionDatetime { get; set; }
        public string TicketTypeName { get; set; }
        public string SeatNumber { get; set; }
        public string BarcodeHandler { get; set; }

    }

}
