namespace ASPT1.Views
{
    public class Pages
    {        
        public string Content { get; set; }
        public Pages()
        {
            Content += "===================================================================================================" + "\n";
            Content += "|--------------------------------------EMPLOYEES MANAGER API--------------------------------------|" + "\n";
            Content += "===================================================================================================" + "\n";
            Content += "GET  /employee    s                                      :Select all employee in database" + "\n";
            Content += "GET  /employee/{id}                                     :Select employee in database with id" + "\n";
            Content += "POST /employee/{name}/{fullname}/{password}/{role}      :Insert new employee EMPLOYEES MANAGER API" + "\n";
            Content += "PUT  /employee/{id}/{name}/{fullname}/{password}/{role} :Update new employee with data" + "\n";

        }

    }
}
