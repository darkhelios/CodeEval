
File.open('texto.txt').each_line do |line|
    
def calcular(numero)
	
	if(0 <= numero && numero <= 2)
		puts("Still in Mama's arms")
	elsif (3 <= numero && numero <= 4)
		puts("Preschool Maniac")
	elsif (5 <= numero && numero <= 11)
		puts("Elementary school")
	elsif (12 <= numero && numero <= 14)
		puts("Middle school")
	elsif (15 <= numero && numero <= 18)
		puts('High school')
	elsif (19 <= numero && numero <= 22)
		puts('College')
	elsif (23 <= numero && numero <= 65)
		puts('Working for the man')
	elsif (66 <= numero && numero <= 100)
		puts('The Golden Years' )
	elsif (numero > 100)
		puts("This program is for humans")
	end

		

end

calcular(line.to_i)
end
