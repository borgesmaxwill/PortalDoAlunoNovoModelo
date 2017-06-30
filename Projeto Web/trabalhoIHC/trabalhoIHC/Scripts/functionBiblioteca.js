//Biblioteca
function BuscarBibliotecaOk() {
	$("#resultadoRequisicaoMobile").show();
	$("#txtTituloMobile").focus();
	LimparTela();
}

function BuscarBibliotecaFalhou() {
	toastr.error("Ops", "Erro ao iniciar formulário!");
}

function BuscarBibliotecaPostOk() {
	$("#resultadoRequisicaoMobile").show();
    window.location.hash = '#resultadoRequisicaoMobile';
}

function BuscarBibliotecaPostFalhou() {
	toastr.error("Ops", "Erro ao retornar dados da consulta!");
}

function BuscarBibliotecaItemOk() {
    $("#resultadoRequisicao").show();
    $("#txtTitulo").focus();
}

function BuscarBibliotecaItemFalhou() {
    toastr.error("Ops", "Erro ao iniciar formulário!");
}

function BuscarBibliotecaPostItemOk() {
    $("#resultadoRequisicao").show();
}

function BuscarBibliotecaPostItemFalhou() {
    toastr.error("Ops", "Erro ao iniciar formulário!");
}

//Secretaria
function BuscarRegistrosDocumentosOk() {
	$("#resultadoRequisicaoMobile").show();
    window.location.hash = '#resultadoRequisicaoMobile';
	LimparTela();
}

function BuscarRegistrosDocumentosFalhou() {
	toastr.error("Ops", "Erro ao iniciar lista!");
}

function SolicitouDocumentosOk(response) {
    $("#requisicao").html(response);
	toastr.success("Sucesso", "Documento solicitado com sucesso!");
}

function SolicitouDocumentosFalhou() {
    toastr.error("Ops", "Erro ao iniciar lista!");
}

function BuscarRegistrosDocumentosItemOk() {
	$("#resultadoRequisicao").show();
    $("#optradio").focus();
}

function BuscarRegistrosDocumentosItemFalhou() {
    toastr.error("Ops", "Erro ao iniciar lista!");
}

function SolicitarDocumentosOk() {
	$("#resultadoRequisicaoMobile").show();
    window.location.hash = '#resultadoRequisicaoMobile';
    LimparTela();
}

function SolicitarDocumentosFalhou() {
    toastr.error("Ops", "Erro ao iniciar lista!");
}

function TrazerDocumentosSolicitadosItemFalhou() {
    toastr.error("Ops", "Erro ao iniciar lista!");
}

function TrazerDocumentosSolicitadosItemOk() {
    $("#resultadoRequisicao").show();
}

//Academico
function BuscarQuadroDeHorariosOk() {
	$("#resultadoRequisicaoMobile").show();
    window.location.hash = '#resultadoRequisicaoMobile';
    LimparTela();
}

function BuscarQuadroDeHorariosFalhou() {
    toastr.error("Ops", "Erro ao trazer quadro de horários!");
}

function BuscarNotasEFaltasOk() {
	$("#resultadoRequisicaoMobile").show();
    window.location.hash = '#resultadoRequisicaoMobile';
    LimparTela();
}

function BuscarNotasEFaltasFalhou() {
    toastr.error("Ops", "Erro ao trazer quadro de notas e faltas!");
}

function BuscarGradeAcademicaOk() {
	$("#resultadoRequisicaoMobile").show();
    LimparTela();
}

function BuscarGradeAcademicaFalhou() {
    toastr.error("Ops", "Erro ao trazer quadro de notas e faltas!");
}

function QuadroDeHorariosItemOk() {
    $("#resultadoRequisicao").show();
}

function QuadroDeHorariosItemFalhou() {
    toastr.error("Ops", "Erro ao trazer quadro de notas e faltas!");
}

function GradeAcademicaItemOk() {
    $("#resultadoRequisicao").show();
}

function GradeAcademicaItemFalhou() {
    toastr.error("Ops", "Erro ao trazer quadro de notas e faltas!");
}

function NotasEFaltasItemOk() {
    $("#resultadoRequisicao").show();
}

function NotasEFaltasItemFalhou() {
    toastr.error("Ops", "Erro ao trazer quadro de notas e faltas!");
}


//Calendario
function RetornarCalendarioOk(){
	$("#resultadoRequisicaoMobile").show();
    window.location.hash = '#resultadoRequisicaoMobile';
    //CarregarCalendario();
}

function RetornarCalendarioFalhou() {
    toastr.error("Ops", "Erro ao trazer calendario!");
}


//Função Extra
function LimparTela() {
	event.preventDefault();
	$('body').toggleClass('navbar-more-show');
	$('a[href="#navbar-more-show"]').closest('li').removeClass('active');
}