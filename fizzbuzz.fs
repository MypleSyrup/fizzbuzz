variable count 1 count !
variable state 0 state !
variable limit 100 limit !

: testIsFizz dup 3 mod 0 = if 1 else 0 then state @ + state ! ;
: testIsBuzz dup 5 mod 0 = if 2 else 0 then state @ + state ! ;

: stateUpdate 0 state ! count @ testIsFizz testIsBuzz drop ;

: stateShow
	state @ 0 = if count @ . then
	state @ 1 = if ." fizz " then
	state @ 2 = if ." buzz " then
	state @ 3 = if ." fizzbuzz " then	
;

: testLimit count @ limit @ > invert ;
: incrementCount count @ 1 + count ! ;

: main
	begin
		stateUpdate
		stateShow
		incrementCount
		testLimit
	while
	repeat
;

main

