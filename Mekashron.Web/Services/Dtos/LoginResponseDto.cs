namespace Mekashron.Web.Services.Dtos
{
    public class LoginResponseDto
    {
        public int EntityId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Company { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Zip { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public int EmailConfirm { get; set; }
        public int MobileConfirm { get; set; }
        public int CountryID { get; set; }
        public int Status { get; set; }


        public override string ToString()
        {
            return $"EntityId: {EntityId}, Email: {Email}, Phone: {Mobile}.";
        }

    }

    /*
     * {"EntityId":3196,"FirstName":"","LastName":"","Company":"","Address":"","City":"","Country":
     * "","Zip":"","Phone":"","Mobile":"+380979078436","Email":"abc@test.com","EmailConfirm":0,
     * "MobileConfirm":0,"CountryID":804,"Status":0,"lid":"f57%3A%3De%C2%80gfxDwi0xsg%C2%80qe%5D5c7698%3Ax","FTPHost":"lease4.mekashron.com","FTPPort":221}
     */
}
