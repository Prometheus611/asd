let age = null
    do{
            age = prompt("Hány éves vagy? (18-100)")
    }while (isNaN(age)||age<18||age>100)

    const max_pulz = 200 - (age/2)

        console.log("kerekítve:",Math.round(max_pulz),Math.floor(max_pulz))
        console.log(max_pulz.toFixed(1))
        console.log(parseInt(max_pulz))

    alert("korból számított max pulzus: "+max_pulz)

    let zonak = new Array
    for (let index = 0; index < 5; index++) {
        zonak[index]=Math.round((0.5+(index/10))*max_pulz)
    }

    const idk = ["alacsony","kozepes","aerob","eros","anaerob"]
    for (let index = 0; index < idk.length; index++) {
        if (index+1==5) {
            document.getElementById(idk[index]).innerText= `(${zonak[index]}bpm)`
            break
        }
        document.getElementById(idk[index]).innerText= `(${zonak[index]} - ${zonak[index+1]}bpm)`
    }