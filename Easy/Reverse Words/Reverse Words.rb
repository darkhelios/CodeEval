File.open('texto.txt').each_line do |line|

	line_s  = line.split(" ")

		word = line_s.reverse

		puts word.join(" ")
	
end