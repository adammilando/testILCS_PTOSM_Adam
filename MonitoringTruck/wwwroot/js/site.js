// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $.getJSON('/Truck/GetTruckData', function (data) {
        // Parse and group data
        var groupedData = {};
        for (var i = 0; i < data.length; i++) {
            var date = new Date(data[i].CREATION_DATE).toLocaleDateString();
            if (groupedData[date]) {
                groupedData[date].nettoTotal += data[i].NETTO;
                groupedData[date].trucks.push(data[i]);
            } else {
                groupedData[date] = { nettoTotal: data[i].NETTO, trucks: [data[i]] };
            }
        }

        // Create chart
        var ctx = document.getElementById('chart').getContext('2d');
        var chart = new Chart(ctx, {
            type: 'bar',
            data: {
                labels: Object.keys(groupedData),
                datasets: [{
                    label: 'Netto',
                    data: Object.values(groupedData).map(d => d.nettoTotal),
                    backgroundColor: 'rgba(75, 192, 192, 0.2)',
                    borderColor: 'rgba(75, 192, 192, 1)',
                    borderWidth: 1
                }]
            },
            options: {
                scales: {
                    y: { beginAtZero: true }
                }
            }
        });

        // Add click event to chart bars
        chart.canvas.onclick = function (e) {
            var activePoint = chart.getElementsAtEventForMode(e, 'nearest', { intersect: true }, true)[0];
            var date = chart.data.labels[activePoint.index];
            var trucks = groupedData[date].trucks;

            // Fill table with truck data
            var tbody = $('#table tbody');
            tbody.empty();
            for (var i = 0; i < trucks.length; i++) {
                tbody.append('<tr><td>' + trucks[i].NO_JOB + '</td><td>' + trucks[i].PLAT_NO + '</td><td>' + trucks[i].NETTO + '</td><td>' + date + '</td></tr>');
            }
        };
    });
});
