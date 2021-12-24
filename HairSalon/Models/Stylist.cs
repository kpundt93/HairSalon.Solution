using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
    
    public int StylistId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Specialty { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
    public string FullName 
    {
      get { return FirstName + " " + LastName ;}
    }
  }
}