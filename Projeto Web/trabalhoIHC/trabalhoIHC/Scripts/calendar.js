function CarregarCalendario() {
    var date = new Date();
    var d = date.getDate();
    var m = date.getMonth();
    var y = date.getFullYear();

    $.getScript('http://arshaw.com/js/fullcalendar-1.6.4/fullcalendar/fullcalendar.min.js', function () {

        $('#calendar').fullCalendar({
            ignoreTimezone: true,
            monthNames: ['Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho', 'Julho', 'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro'],
            monthNamesShort: ['Jan', 'Fev', 'Mar', 'Abr', 'Mai', 'Jun', 'Jul', 'Ago', 'Set', 'Out', 'Nov', 'Dez'],
            dayNames: ['Domingo', 'Segunda', 'Terça', 'Quarta', 'Quinta', 'Sexta', 'Sabado'],
            dayNamesShort: ['Dom', 'Seg', 'Ter', 'Qua', 'Qui', 'Sex', 'Sab'],
            titleFormat: {
                month: 'MMMM yyyy',
                week: "d[ MMMM][ yyyy]{ - d MMMM yyyy}",
                day: 'dddd, d MMMM yyyy'
            },
            columnFormat: {
                month: 'ddd',
                week: 'ddd d',
                day: ''
            },
            axisFormat: 'H:mm',
            timeFormat: {
                '': 'H:mm',
                agenda: 'H:mm{ - H:mm}'
            },
            buttonText: {
                today: "Hoje",
                month: "Mês",
                week: "Semana",
                day: "Dia"
            },
            header: {
                left: 'prev,next today',
                center: 'title',
                right: 'month,agendaWeek,agendaDay'
            },
            editable: true,
            events: [
                {
                    title: 'Avaliação Oficial',
                    start: new Date(y, m, 26)
                },
                {
                    title: 'Avaliação Oficial',
                    start: new Date(y, m, 27)
                },
                {
                    title: 'Avaliação Oficial',
                    start: new Date(y, m, 28)
                },
                {
                    title: 'Avaliação Oficial',
                    start: new Date(y, m, 29)
                },
                {
                    title: 'Avaliação Oficial',
                    start: new Date(y, m, 30)
                }
            ]
        });
    });
}
