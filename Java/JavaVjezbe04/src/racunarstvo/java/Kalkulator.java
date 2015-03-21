package racunarstvo.java;

import java.util.Stack;

public class Kalkulator {

    public static void main(String[] args) {

        String infix = "(6+7*8-(6+2)*3)";
        
        String postfix = toPostfix(infix);
        System.out.println(postfix);
        int rezultat = izracunaj(postfix);
        System.out.println(rezultat);
    }

    private static String toPostfix(String infix) {
        
        Stack<Character> stc = new Stack<>();
        StringBuilder str = new StringBuilder();
        
        try {
            for(char c : infix.toCharArray()) {
                
                 if (c == '(')
                    {
                        stc.push(c);
                    }
                    else if (Character.isDigit(c))
                    {
                        str.append(c);
                    }
                    else if (c == ')')
                    {
                        while (!(stc.peek().equals('(')))
                        {
                            str.append(stc.pop());
                        }
                        stc.pop();
                    }
                    else if (c == '*')
                    {
                        stc.push(c);
                    }
                    else if (c == '+' || c == '-')
                    {
                        if (stc.peek().equals('('))
                        {
                            stc.push(c);
                        }
                        else
                        {
                            while (stc.peek().equals('+') || stc.peek().equals('-') || stc.peek().equals('*'))
                            {
                                str.append(stc.pop());
                            }
                            stc.push(c);
                        }
                    }
                }

                return str.toString();
        }
        catch(Exception e) {
            return "Izraz nije ispravan!";
        }
    }

    private static int izracunaj(String postfix) {
        Stack<Integer> stc = new Stack<>();
        int tempA, tempB;
        
        for(char c : postfix.toCharArray()) {
            if(Character.isDigit(c)) {
                stc.push((int)Character.getNumericValue(c));
            }
            else if(c == '+') {
                tempA = stc.pop();
                tempB = stc.pop();
                stc.push(tempA + tempB);
            }
            else if(c == '-') {
                tempA = stc.pop();
                tempB = stc.pop();
                stc.push(tempB - tempA);
            }
            else if(c == '*') {
                tempA = stc.pop();
                tempB = stc.pop();
                stc.push(tempB * tempA);
            }
        }
        
        return stc.pop();
    }
}
