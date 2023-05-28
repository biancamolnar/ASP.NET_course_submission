try {
    const toggleBtn = document.querySelector('[data-option="toggle"]')
    toggleBtn.addEventListener('click', function () {
        const element = document.querySelector(toggleBtn.getAttribute('data-target'))

        if (!element.classList.contains('open-menu')) {
            element.classList.add('open-menu')
            toggleBtn.classList.add('btn-outline-dark')
            toggleBtn.classList.add('btn-toggle-white')
        }

        else {
            element.classList.remove('open-menu')
            toggleBtn.classList.remove('btn-outline-dark')
            toggleBtn.classList.remove('btn-toggle-white')
        }
    })
} catch { }

const validateText = (event) => {
    if (event.target.value.length >= 2) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""
    } else {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "invalid length"
    }
}

const validateEmail = (event) => {
    const regEx = /^[^\s@]+@[^\s@]+\.[^\s@]+$/
    if (regEx.test(event.target.value)) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""
    } else {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "invalid email"
    }
}

const validatePassword = (event) => {
    const regEx = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^^&*]).{8,}$/
    if (regEx.test(event.target.value)) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""
    } else {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "invalid password"
    }
}

function validateRequired(e) {
    validationfield = document.querySelector(`[data-valmsg-for="${e.target.id}"]`)

    if (e.target.value.length >= 1)
        validationfield.innerHTML = ""
    else
        validationfield.innerHTML = e.target.dataset.valRequired
}

function footerPosition(element, scrollHeight, innerHeight) {
    try {
        const _element = document.querySelector(element)
        const isTallerThanScreen = scrollHeight >= innerHeight

        _element.classList.toggle('position-fixed-bottom', !isTallerThanScreen)
        _element.classList.toggle('position-static', isTallerThanScreen)
    } catch { }
}
footerPosition('footer', document.body.scrollHeight, window.innerHeight)




