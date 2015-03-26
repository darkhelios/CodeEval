File.open('texto.txt').each_line do |line|

	line = line.strip
	line = line.split('')

	x = line.length

	if x%2 == 0
		line = line.uniq
		puts line.length
	elsif x%2 != 0
		line = line.uniq
		puts line.length
	end
		
end