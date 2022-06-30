let numeroAlunos = 10;

for(let contador = 0; contador < numeroAlunos; contador++) {
    // Resto % -> Retorna o valor de uma divisão inteira

    if(contador == 0){
        console.log(`O número ${contador} é ZERO`)
    } else if(contador % 2 == 0) {
        
        //Concatenação
        console.log(`O numero ` + contador + ` é PAR`)

        // Interpolação
    }else if(contador % 2 == 1){
        console.log (`O numero ${contador} é IMPAR`)
    }
}