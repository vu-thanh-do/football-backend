using N.Model.Entities;
using N.Service.BookingService.Dto;

namespace N.Service.InviteService.Dto
{
    public class InviteDto : Invite
    {
        public Team? Team { get; set; }
        public Team? InviteTeam { get; set; }
        public BookingDto? Booking { get; set; }
    }
    public class InviteDto2 : Invite
    {
        public Team? Team { get; set; }
        public Team? InviteTeam { get; set; }
        public BookingDto? Booking { get; set; }
        public Team? Accepted { get; set; }

    }
}
