File.open('texto.txt').each_line do |line|

  line = line.strip 	
  line = line.split('')
  
  line = line.map(&:to_i)

  puts line.inject(:+)

end