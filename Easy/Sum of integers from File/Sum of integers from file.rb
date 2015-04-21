num = []
x = 0
total = 0

File.open('texto.txt').each_line do |line|

	num[x] = line.to_i
  	x+=1

end

	while x>0
 		 x-=1
  		total += num[x]
	end

	puts total