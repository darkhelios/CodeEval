File.open('texto.txt').each_line do |line|

	line = line.split(',')

	x = line[0].to_s
	y = line[1].to_s
	x = x.strip
	y = y.strip

	if x[y]
  puts '1'
	else
  puts '0'
	end
end