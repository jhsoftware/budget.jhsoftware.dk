[Spirit.Route(["/","/vue","/svelte"])]
class IndexPage : Spirit.Page {

  public override Spirit.HtmlBlock Render() {
    if (Context.Request.Host.Value != "budget.jhsoftware.dk") return RenderMove();

    var p = Context.Request.Path.ToString();

    return h($@"<!DOCTYPE html>
<html>
<head>
  <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

  <title>budget.jhsoftware.dk</title>

  <link href={JAH.StaticFileHash("css/mit-budget.css")} rel=""stylesheet"" />
  <script src={JAH.StaticFileHash("scripts/bootstrap.min.js")}></script>

  {(p=="/vue" ? h($@"
  <script src={JAH.StaticFileHash("scripts/vue.runtime.min.js")}></script>
  <script defer src={JAH.StaticFileHash("scripts/mit-budget-vue.js")}></script>
") : (p=="/svelte" ? h($@"
  <script defer src={JAH.StaticFileHash("scripts/mit-budget-svelte.js")}></script>
") : h($@"
  <script src={JAH.StaticFileHash("katla/katla.js")}></script>
  <script defer src={JAH.StaticFileHash("scripts/mit-budget-katla.js")}></script>
")))}

  <script defer data-domain=""budget.jhsoftware.dk"" data-api=""/pl/event"" src=""/pl/script""></script>

</head>
<body style=""background-color:#ccc"">

  <div style=""display:flex;flex-direction:column;max-width:960px;margin:0 auto;background-color:white;min-height:100vh"" id=""base"">

    <div style=""padding: 1rem;flex-grow:1"">

      <div class=""d-flex"">

        <h1 class=""text-primary me-auto"">budget.jhsoftware.dk</h1>

        <a href='https://ko-fi.com/jesperhoy' target='_blank'><img height='36' style='border:0px;height:36px;' src='https://cdn.ko-fi.com/cdn/kofi2.png?v=2' border='0' alt='Buy Me a Coffee at ko-fi.com' /></a>
      </div>

      <hr />

      <div id=""intro"">

        <p>budget.jhsoftware.dk er en gratis web-applikation (et program som kører i din browser) som gør det nemt at lave og arbejde med et personligt eller virksomheds-relateret budget.</p>

        <p>
          budget.jhsoftware.dk er smartere end de Excel budget-skabeloner man kan finde på nettet, netop fordi det er et rigtigt program og ikke bare et regneark.
          Et budget på budget.jhsoftware.dk er også nemmere at dele med andre, fordi modtagere ikke behøver Excel, men bare en browser.
        </p>

        <p>
          budget.jhsoftware.dk er inspireret af budget-funktionen i diverse netbanker,
          men i modsætning til disse bliver man ikke smidt ud af budget.jhsoftware.dk efter 10 minutters inaktivitet,
          og man mister ikke sit budget på budget.jhsoftware.dk når man skifter bank.
        </p>

        <p>På budget.jhsoftware.dk er man anonym - så længe man ikke taster personlige oplysninger (navn, adresse, CPR-nr., etc.) ind - hvilket der ikke burde være nogen grund til.</p>

        <p>
          Når du gemmer et budget på budget.jhsoftware.dk, så får budgettet sin helt egen unikke og umulig-at-gætte permanente Internet-adresse (indtil du evt. sletter det).
          Denne adresse kan nemt deles med andre - inkl. bank-rådgiver, revisor, mv.
        </p>

        <p>budget.jhsoftware.dk er Open Source - så hvis du er til den slags, kan du <a href=""https://github.com/jhsoftware/budget.jhsoftware.dk"" target=""_blank"">se og bidrage til kilde-koden på GitHub</a>.</p>

        <p>Hvis du finder fejl eller mangler i budget.jhsoftware.dk, kan du rapportere det ved at oprette et <a href=""https://github.com/jhsoftware/budget.jhsoftware.dk/issues"" target=""_blank"">""Issue"" på GitHub</a></p>

        <p>Klik på knappen ""Nyt budget"" herunder for at komme i gang.</p>

      </div>

      <div id=""app""></div>

    </div>


    <div class=""text-center bg-primary text-white p-2"">
      budget.jhsoftware.dk
      &bull; &copy; 2021-{DateTime.Now.Year} <a class=""link-light"" href=""https://jhsoftware.dk"" target=""blank"">JH Software</a>
      &bull; <a class=""link-light"" href=""https://github.com/jhsoftware/budget.jhsoftware.dk"" target=""_blank"">Kildekode</a>
      &bull; <a class=""link-light"" href=""https://github.com/jhsoftware/budget.jhsoftware.dk/issues"" target=""_blank"">Rapporter fejl/mangler</a>
    </div>

  </div>

</body>
</html>
");
  }

  public Spirit.HtmlBlock RenderMove() {
    return h($$$"""
<!DOCTYPE html>
<html>
<head>
  <meta name="viewport" content="width=device-width, initial-scale=1">     
  <title>budget.jhsoftware.dk</title>
  <link href={{{JAH.StaticFileHash("css/mit-budget.css")}}} rel="stylesheet" />
  <script defer data-domain="budget.jhsoftware.dk" data-api="/pl/event" src="/pl/script"></script>      
</head>
<body style="background-color:#ccc">      
  <div style="display:flex;flex-direction:column;max-width:960px;margin:0 auto;background-color:white;min-height:100vh" id="base">     
    <div style="padding: 1rem;flex-grow:1">
      <h1 class="text-primary me-auto">budget.jhsoftware.dk</h1>    
      <hr />
      <h3>Vi er flyttet!</h3>
      <p>Mit-Budget.dk er nu <a href="https://budget.jhsoftware.dk">budget.jhsoftware.dk</a></p>

<script>
var h=document.location.hash;
if(h.length>1) {
  var nyurl="https://budget.jhsoftware.dk/"+h;
  document.write(`<p>Dit budget findes nu på adressen: <a href="${nyurl}">${nyurl}</a></p>
<p><b>VIGTIGT:</b> Gem den nye addresse et sikkert sted.<br/>
Den gamle adresse (under mit-budget.dk) vil <b>IKKE</b> virke efter 31.12.2026.</p>`);
}
</script>


    </div>
            
    <div class="text-center bg-primary text-white p-2">
      budget.jhsoftware.dk
      &bull; &copy; 2021-{{{DateTime.Now.Year}}} <a class="link-light" href="https://jhsoftware.dk" target="blank">JH Software</a>
      &bull; <a class="link-light" href="https://github.com/jhsoftware/budget.jhsoftware.dk" target="_blank">Kildekode</a>
      &bull; <a class="link-light" href="https://github.com/jhsoftware/budget.jhsoftware.dk/issues" target="_blank">Rapporter fejl/mangler</a>
    </div>
      
  </div>     
</body>
</html>
""");
  }

}