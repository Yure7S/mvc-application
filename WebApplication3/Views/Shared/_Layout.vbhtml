<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Meu Aplicativo ASP.NET</title>
    @Scripts.Render("~/bundles/modernizr")
    @Styles.Render("~/Content/css")
</head>
<body>
    <header style="" id="header" role="banner" ">
        <a href="#" class="sr-only" name="inicioTopo">Topo</a>
        

        <div id="BarraBrasil" class="hidden-print" hidden="true">
            <div id="barra-brasil"><div id="wrapper-barra-brasil"><div class="brasil-flag"><a href="https://gov.br" class="link-barra">Brasil</a></div><nav><ul id="lista-barra-brasil" class="list"><li><a href="#" id="menu-icon"><p class="sr-only">Ativar menu da barra Brasil</p></a></li><li class="list-item first"><a href="http://www.saude.gov.br/coronavirus" style="color:red;">CORONAVÍRUS (COVID-19)</a></li><li class="list-item"><a href="http://www.simplifique.gov.br" class="link-barra">Simplifique!</a></li><li class="list-item"><a href="https://www.gov.br/pt-br/participacao-social/" class="link-barra">Participe</a></li><li class="list-item"><a href="http://www.acessoainformacao.gov.br" class="link-barra">Acesso à informação</a></li><li class="list-item"><a href="http://www.planalto.gov.br/legislacao" class="link-barra">Legislação</a></li><li class="list-item last last-item"><a href="https://gov.br/pt-br/canais-do-executivo-federal" class="link-barra">Canais</a></li></ul></nav><span id="brasil-vlibras"><a class="logo-vlibras" id="logovlibras" href="#"><p class="sr-only">Ativar conteúdo acessível com libras</p></a><span class="link-vlibras"><img src="data:image/gif;base64,R0lGODlhAQABAIAAAAUEBAAAACwAAAAAAQABAAACAkQBADs=" class="barralazy" data-src="//barra.brasil.gov.br/imagens/vlibras.gif" width="132" height="116">&nbsp;<br>O conteúdo desse portal pode ser acessível em Libras usando o <a href="http://www.vlibras.gov.br">VLibras</a></span></span></div></div>
        </div>



        <div id="pnlCabecalho">


            <div class="eouv-header">
                <div class="container">

                    <div class="row">
                        <div class="col-md-8 divTitulo">
                            <h1 class="eouv-titulo" style="margin: 35px 0px 0px 0px">
                                <a style="font-weight: bold;" id="lnkSistemaTopo" href="../../">e-OUV</a>
                            </h1>
                        </div>
                        <div class="col-md-4">
                            <div>
                                <!--  -->
                                <img src="~/Content/images/logo_negativa.png" id="img2" alt="Secretaria de Transparencia e Controle do Estado do Maranhão" style="margin: 35px 0px 0px 0px; width: 150px;">
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-10">
                            <h3>
                                <span id="lblTituloSistema">Sistema de Ouvidorias do Poder Executivo do Estado do Maranhão</span>
                            </h3>
                        </div>
                        <div class="col-md-2 text-right" style="margin: 25px 0px 0px 0px">
                            terça-feira, 28/03/2023
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-9">
                            <h2 class="nomeMinisterio"></h2>
                        </div>
                        <div class="col-md-3 text-right">
                            <span id="ltAmbiente"></span>
                        </div>
                    </div>
                </div>
            </div>


        </div>
    </header>
    <main class="container-md">
        @RenderBody()
    </main>
    <hr />
    <footer id="footer" class="hidden-print" role="contentinfo">
        <a href="#" class="sr-only" id="inicioRodape" name="inicioRodape">Início do Rodapé</a>
        <div class="text-center">
            <a href="#inicioTopo" accesskey="9">Voltar ao Topo</a>
        </div>
        <div class="footer">
            <div id="footer-ma" style="padding: 1em 0px; max-width: 100%;">

                <div id="wrapper-footer-brasil">
                    <a href="http://www.e-sic.ma.gov.br">
                        <img src=" data:image/svg+xml,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%20117%2049%22%20height%3D%2249%22%20width%3D%22117%22%20shape-rendering%3D%22geometricPrecision%22%20text-rendering%3D%22geometricPrecision%22%3E%3Cdefs%3E%3Cstyle%20type%3D%22text%2Fcss%22%3E%3C!%5BCDATA%5B.a%20%7Bfont%3A%20normal%20bold%2011px%20Open%20Sans%2C%20sans-serif%3B%7D%5D%5D%3E%3C%2Fstyle%3E%3C%2Fdefs%3E%3Ccircle%20cx%3D%2222%22%20cy%3D%2223%22%20r%3D%2222%22%20fill%3D%22%23f6a800%22%2F%3E%3Cpath%20style%3D%22stroke%3A%23f6a800%3Bstroke-width%3A4%3Bstroke-linejoin%3Around%3B%22%20d%3D%22m%204%2C43%203%2C-6%204%2C3%20z%22%2F%3E%3Ccircle%20r%3D%224.5%22%20cy%3D%2211%22%20cx%3D%2222%22%20fill%3D%22%2300692c%22%2F%3E%3Cg%20fill%3D%22%23fff%22%3E%3Ctext%20x%3D%2248%22%20y%3D%2222%22%3E%3Ctspan%20class%3D%22a%22%20y%3D%2218%22%3EAcesso%20%C3%A0%3C%2Ftspan%3E%3Ctspan%20class%3D%22a%22%20x%3D%2248%22%20y%3D%2231%22%3EInforma%C3%A7%C3%A3o%3C%2Ftspan%3E%3C%2Ftext%3E%3C%2Fg%3E%3Cpath%20style%3D%22stroke%3A%2300692c%3Bstroke-width%3A9%3Bstroke-linecap%3Around%3B%22%20d%3D%22m%2022%2C23%20v%2013%22%2F%3E%3C%2Fsvg%3E"

                        <span class="logo-acesso-footer"></span>
                        <p class="sr-only">link para a página do serviço de acesso a informação ao cidadão do Governo do Maranhão</p>
                        <p class="sr-only">link para a página do serviço de acesso a informação ao cidadão</p>
                    </a>
                </div>

            </div>
            <div class="container">
                <div class="row">
                    <div class="col-xs-4 text-center">
                        <small>
                            Sistema cedido pela
                            <br>
                            Controladoria-Geral da União
                        </small>
                    </div>
                    <div class="col-xs-4 text-center">
                        <small>
                            Gestão do Sistema pela<br>
                            Secretaria de Estado de Transparência e Controle
                        </small>
                    </div>
                    <div class="col-xs-4 text-center">
                        <small>
                            Versão
                            4.11.0<br>
                            Direitos reservados CGU/2017
                        </small>
                    </div>
                </div>
            </div>
        </div>
    </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")*
    @RenderSection("scripts", required:=False)
</body>
</html>
