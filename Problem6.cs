using System;
class Order{
    public int OrderId { get; set; }
    public string OrderDate { get; set; }
    public Order(int orderid, string orderdate){
        OrderId = orderid;
        OrderDate = orderdate;
    }
    public virtual void GetOrderStatus(){
        Console.WriteLine("Order Status: Pending");
        Console.WriteLine($"Order Id: {OrderId}, Order Date: {OrderDate}\n");
    }
}
class ShippedOrder : Order{
    public string TrackingNumber { get; set; }
    public ShippedOrder(int orderid, string orderdate, string trackingnumber) : base(orderid, orderdate){
        TrackingNumber = trackingnumber;
    }
    public override void GetOrderStatus(){
        Console.WriteLine("Order Status: Shipped");
        Console.WriteLine($"Order Id: {OrderId}, Order Date: {OrderDate}, Tracking Number: {TrackingNumber}\n");
    }
}
class DileveredOrder : ShippedOrder{
    public string DeliveryDate { get; set; }
    public DileveredOrder(int orderid, string orderdate, string trackingnumber, string deliverydate) : base(orderid, orderdate, trackingnumber){
        DeliveryDate = deliverydate;
    }
    public override void GetOrderStatus(){
        Console.WriteLine("Order Status: Delivered");
        Console.WriteLine($"Order Id: {OrderId}, Order Date: {OrderDate}, Tracking Number: {TrackingNumber}, Delivery Date: {DeliveryDate}\n");
    }
}
class Problem6{
    public static void Main(string[] args) {
        Order order = new Order(1, "2025-01-01");
        ShippedOrder shippedorder = new ShippedOrder(2, "2025-01-02", "123456");
        DileveredOrder deliveredorder = new DileveredOrder(3, "2025-01-03", "654321", "2025-01-07");
        order.GetOrderStatus();
        shippedorder.GetOrderStatus();
        deliveredorder.GetOrderStatus();
    }
}
