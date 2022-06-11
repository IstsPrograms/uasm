

CodeInterpritator(System.IO.File.ReadAllText("main.uasm"));
Console.ReadKey();
int CodeInterpritator(string code) {
    try {
        byte[] memory = new byte[120];
        byte[,] sb_memory = new byte[120, 120];
        string[] splitted_code = new string[1024];
        splitted_code = code.Split("\n");

        for(int i = 0; i < splitted_code.Length; i++) {
            string[] this_line = new string[16];
            this_line = splitted_code[i].Split(" ");
            for(int b = 0; b < this_line.Length; b++) {
                if(this_line[b] == "" || this_line[b] == null) {
                    continue;
                }
                else {
                    switch(this_line[b]) {
                        case "mw":
                            memory[F16TO10(this_line[b+1])] = (byte)F16TO10(this_line[b+2]);
                            break;
                        case "mr":
                            if(this_line[b+2] == "1") {
                                Console.Write(memory[F16TO10(this_line[b+1])]);
                            }
                            if(this_line[b+2] == "2") {
                                Console.WriteLine(memory[F16TO10(this_line[b+1])]);
                            }
                            if(this_line[b+2] == "3") {
                                Console.Write((char)memory[F16TO10(this_line[b+1])]);
                            }
                            if(this_line[b+2] == "4") {
                                Console.WriteLine((char)memory[F16TO10(this_line[b+1])]);
                            }
                            break;
                        case "sbw":
                            for(int d = 0; d < this_line[b+2].Split(",").Length; d++) {
                                if(this_line[b+2].Split(",")[d][0] == 'Q') {
                                    sb_memory[F16TO10(this_line[b+1]), d] = memory[F16TO10(this_line[b+2].Split(",")[d])];
                                }
                                else {
                                    sb_memory[F16TO10(this_line[b+1]), d] = (byte)F16TO10(this_line[b+2].Split(",")[d]);
                                }
                                
                            }
                            break;
                        case "sbr":
                            for(int d = 0; d < 120; d++) {
                                switch(this_line[b+2]) {
                                    case "1":
                                        if(sb_memory[F16TO10(this_line[b+1]), d] != 0) {
                                            Console.Write(sb_memory[F16TO10(this_line[b+1]), d]);
                                        }
                                        else {
                                            continue;
                                        }
                                        break;
                                    case "2":
                                        if(sb_memory[F16TO10(this_line[b+1]), d] != 0) {
                                            Console.WriteLine(sb_memory[F16TO10(this_line[b+1]), d]);
                                        }
                                        else {
                                            continue;
                                        }
                                        break;
                                    case "3":
                                        if(sb_memory[F16TO10(this_line[b+1]), d] != 0) {
                                            Console.Write((char)sb_memory[F16TO10(this_line[b+1]), d]);
                                        }
                                        else {
                                            continue;
                                        }
                                        break;
                                    case "4":
                                        if(sb_memory[F16TO10(this_line[b+1]), d] != 0) {
                                            Console.WriteLine((char)sb_memory[F16TO10(this_line[b+1]), d]);
                                        }
                                        else {
                                            continue;
                                        }
                                        break;
                                }
                            }
                            break;
                        case "ADD":
                            memory[F16TO10(this_line[b+1])] += (byte)F16TO10(this_line[b+2]);
                            break;
                        case "SUB":
                            memory[F16TO10(this_line[b+1])] -= (byte)F16TO10(this_line[b+2]);
                            break;
                        case "MUL":
                            memory[F16TO10(this_line[b+1])] *= (byte)F16TO10(this_line[b+2]);
                            break;
                        case "DIV":
                            memory[F16TO10(this_line[b+1])] = (byte)( memory[F16TO10(this_line[b+1])] / (byte)F16TO10(this_line[b+2]));
                            break;
                        case "MOV":
                            memory[F16TO10(this_line[b+2])] = memory[F16TO10(this_line[b+1])];
                            break;
                        case "IN":
                            memory[F16TO10(this_line[b+1])] = System.Convert.ToByte(Console.ReadLine());
                            break;
                            
                    }
                }
            }
        }
    }
    catch {
        return(-1);
    }
    return(0);
}

int F16TO10(string code) {
    int new_code = 0;
    for(int i = 0; i < code.Length; i++) {
        switch(code[i]) {
            case '0':
                new_code += 0;
                break;
            case '1':
                new_code += 1;
                break;
            case '2':
                new_code += 2;
                break;
            case '3':
                new_code += 3;
                break;
            case '4':
                new_code += 4;
                break;
            case '5':
                new_code += 5;
                break;
            case '6':
                new_code += 6;
                break;
            case '7':
                new_code += 7;
                break;
            case '8':
                new_code += 8;
                break;
            case '9':
                new_code += 9;
                break;
            case 'A':
                new_code += 10;
                break;
            case 'B':
                new_code += 11;
                break;
            case 'C':
                new_code += 12;
                break;
            case 'D':
                new_code += 13;
                break;
            case 'E':
                new_code += 14;
                break;
            case 'F':
                new_code += 15;
                break;
            case 'G':
                new_code += 16;
                break;

            
        }
    }
    return(new_code);

}
