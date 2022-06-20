using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;

namespace Umbraco10Demo.Controllers.Api
{
    public class ImportPersonsController : UmbracoApiController
    {
        private readonly IContentService _contentService;

        public ImportPersonsController(IContentService contentService)
        {
            _contentService = contentService;
        }

        public OkResult Import()
        {

            /// Lees hier een CSV uit en importeer deze in het cms onder de volgende node https://localhost:44316/umbraco#/content/content/edit/1107
            /// TIP: doe dit via de IContentService, deze kan je injecten in de constructor. 
            /// Let op. we willen hierbij gebruikers via CSV bijwerken, dus er dient een sleutel bij gehouden te worden op het model in het CMS, hiervoor moet je nog een veld toevoegen.
            /// Zie bijv: https://www.jondjones.com/learn-umbraco-cms/umbraco-9-tutorials/how-tos/how-to-deal-with-content-migration-in-umbraco-9/
            /// en ook https://24days.in/umbraco-cms/2021/advanced-tips-for-content-apps/. hier kan je zien hoe bepaalde zaken worden opgelost
            
            ///Vereisten
            /// 1: Uitlezen van CSV (deze staat in de wwwroot map)
            /// 2. Als persoon al in CMS bestaat dient hij via het bestand geupdate te kunnen worden.
            /// 3. Personen die niet in het bestand staan moeten worden opgeruimd.  (Verwijderd)
            /// Aanvullend: Het zou mooi zijn als je kijkt naar een manier om te zien of de data hetzelfde is Ja of Nee. Hiervoor zou ik een functie voor maken die dit kan. 
            

            return Ok();
        }


        
    }
    
}
