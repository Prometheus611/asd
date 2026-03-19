
//window.alert('Nyisd meg a konzolt!')

/*
* Operátorok
*/

/*
    Operátorok csoportosíthatók:
        - operandusok száma szerint:
            1: unary
            2: binary
            3: ternary
        - operátor lexikális elhelyezkedése
            előtte: prefix
            közötte: infix
            utána: postfix
        - hajt-e végre mellékhatást? (side effect)
            igen
            nem


/*
* Aritmetika
* (number, number) -> number
*/

console.log("2+3=",2+3)
console.log("2-3=",2-3)
console.log("2*3=",2*3)
console.log("2/3=",2/3)
console.log("7%3=",7%3)
console.log("[7/3]=",Math.floor(7/3))
console.log("2^3=",2**3)

let x = 4294967295
const hexdec = x.toString(16).toUpperCase()
console.log(x, x.toString(), x.toString(2)+"b", `${hexdec} h`)

/*
* Összehasonlító
* (any, any) -> boolean
*/

 // == (equality), === (identity)

    console.log(1==true,1===true);
    console.log("1"==true,"1"===true);
    console.log("2"==2,"2"===2);
    x=2
    console.log(Number("2")==x,"2"===x.toString());
    // !=


    // >, <, >=, <=


/*
* Logikai
* (boolean, boolean) -> boolean
    A | B > Y
    0 | 0   _
    0 | 1   _
    1 | 1   _
    1 | 0   _

* (boolean) ->
*/

// logikai ÉS
    console.log("AND gate")
    console.log("0 AND 0",false && false)
    console.log("1 AND 0",true && false)
    console.log("1 AND 1",true && true)

// logikai VAGY
    console.log("OR gate")
    console.log("0 OR 0",false || false)
    console.log("1 OR 0",true || false)
    console.log("1 OR 1",true || true)

// negálás
    console.log("NOT gate")
    console.log("NOT 1",!true)
    console.log("NOT 0",!false)

console.log("példák")
    console.log(2=="2"&&1>5)
    console.log(2==="2"&&1>5||true)
    console.log(2==="2"&&(1>5||true))
/**
 * String operátor
 */
 // konkaktenálás

 // -> 'Hello Word!'
    let message="hello"+" "+"\"world!\""
    console.log(message)
    console.log("hello","\"world!\"")
    let name="Pista"
    console.log("hello."+name+"!")
    console.log(`hello ${name}!`)

/*
* Conditional
* (bool, any, any) -> any
*/
    x=11
    console.log(x>5?"igaz":"hamis")
    let igaz_e = x>5?"igaz":"hamis"
    console.log(igaz_e)

/*
* Assignment
* (const, let var, any) -> any
*/
let pi=3.14
// let pi=math.PI
pi=Math.PI
console.log(pi)

// increment (++ +=), decrement (-- -=)
console.log(++x,x++,x++)
console.log(--x,x--,x--)

// for (let index = 0; index < 20; index++) {
//         let randomInt = Math.floor(Math.random() * 2);
//         if (randomInt==0) {x++}else {x--}
//         console.log(x)
//     }

// szam = szam + 10;

let szam = 10
    console.log(szam+=10)
    console.log(szam*=10)
    console.log(szam/=10)
    console.log(szam%=10)
szam=13.3
    console.log(typeof((((((((((((((((((((((((((((((((((((szam)))))))))))))))))))))))))))))))))))))
    isNaN (szam)? console.log("nem szám"):console.log("szám")

// Mi és ill. milyen típusú lesz az eredmény
console.log ( "Mi és ill. milyen típusú lesz az eredmény" )
    /* 
        2 * "alma" 
        10 + '5'
        10 + 5
        10 < 5
        (10 < 5) ? true : false
        (10 < 5) ? 'true' : 'false'
        (10 > 5) ? 'nagyobb' : kisebb
    */
    console.log("Number NaN")   
    console.log("String 105")   
    console.log("Number 15")   
    console.log("Booline false")
    console.log("Booline false")
    console.log("String false")
    console.log("String nagyobb")


// ture | false
console.log ( " ture | false ")
/* 
        true && true
        1 === true
        1 == 'true'
        true || false
        true && false
        1== true
*/
