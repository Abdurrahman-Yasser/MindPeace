document.addEventListener('DOMContentLoaded', function () {
    const monthYear = document.getElementById('monthYear');
    const calendarBody = document.getElementById('calendarBody');
    const prev = document.getElementById('prev');
    const next = document.getElementById('next');

    let today = new Date();
    let currentMonth = today.getMonth();
    let currentYear = today.getFullYear();

    const months = ["January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December"];

    function showCalendar(month, year) {
        calendarBody.innerHTML = "";

        monthYear.textContent = `${months[month]} ${year}`;

        let firstDay = new Date(year, month).getDay();
        let daysInMonth = 32 - new Date(year, month, 32).getDate();

        let date = 1;
        for (let i = 0; i < 6; i++) {
            let row = document.createElement('tr');

            for (let j = 0; j < 7; j++) {
                if (i === 0 && j < firstDay) {
                    let cell = document.createElement('td');
                    let cellText = document.createTextNode('');
                    cell.appendChild(cellText);
                    row.appendChild(cell);
                } else if (date > daysInMonth) {
                    break;
                } else {
                    let cell = document.createElement('td');
                    let cellText = document.createTextNode(date);
                    if (date === today.getDate() && year === today.getFullYear() && month === today.getMonth()) {
                        cell.classList.add('bg-primary', 'text-white');
                    }
                    cell.appendChild(cellText);
                    row.appendChild(cell);
                    date++;
                }
            }

            calendarBody.appendChild(row);
        }
    }

    prev.addEventListener('click', function () {
        currentYear = (currentMonth === 0) ? currentYear - 1 : currentYear;
        currentMonth = (currentMonth === 0) ? 11 : currentMonth - 1;
        showCalendar(currentMonth, currentYear);
    });

    next.addEventListener('click', function () {
        currentYear = (currentMonth === 11) ? currentYear + 1 : currentYear;
        currentMonth = (currentMonth === 11) ? 0 : currentMonth + 1;
        showCalendar(currentMonth, currentYear);
    });

    showCalendar(currentMonth, currentYear);
});
