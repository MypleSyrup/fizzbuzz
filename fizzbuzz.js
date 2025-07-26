const COUNT_LIMIT = 100 ;

const COUNT_ARRAY = [] ;



function format (int) {  // int

	const isFizz = (int % 3) === 0 ;

	const isBuzz = (int % 5) === 0 ;

	if ( ! isFizz && ! isBuzz) {

		return `${int}` ;

	}

	if (isFizz && isBuzz) {

		return 'FizzBuzz' ;

	}

	if (isFizz) {

		return 'Fizz' ;

	}

	// else, is buzz
	return 'Buzz' ;

}



for (let i = 1 ; i <= COUNT_LIMIT ; i++) {

	const formattedResult = format (i) ;

	COUNT_ARRAY.push (formattedResult) ;

}



console.log (COUNT_ARRAY) ;

