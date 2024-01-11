namespace AuctionService.Entities;

public class Auction
{
    public Guid Id { get; set; }
    public int ReservePrice { get; set; } = 0;
    public string Seller { get; set; }
    public string Winner { get; set; }
    public int SoldAmount { get; set; } = 0;
    public bool CurrentHighBid { get; set; }

    public Status Status { get; set; }
    public Item Item { get; set; }


}