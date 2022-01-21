using System.Collections.Generic;

namespace Domain
{
    public class Supplier : BaseModel
    {
        
        public override string ToString()
        {
            return new string($"Id: {Id} Name: {Name} Description: {Description}");
        }

        /*@foreach(var element in Model.Products)
        {@*< div class="row row-cols-3 row-cols-md-2 g-4" style="display: inline-block; max-width: 350px; height: 350px; padding-bottom:10px">
                <div class="card">
                }

                </ div >
                </ div >
                </ div > *@*/
    }
}
