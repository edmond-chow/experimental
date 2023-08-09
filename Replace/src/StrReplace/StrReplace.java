package StrReplace;
public class StrReplace {
    private StrReplace() { };
    public static String replace(final String str, final String find, final String replace) {
        String input = str;
        StringBuilder output = new StringBuilder();
        if (find == "") {
            for (int i = 0; i < input.length(); ++i) { output.append(replace + input.charAt(i)); }
            return output.append(replace).toString();
        } else {
            while (true) {
                if (input.indexOf(find) > -1) {
                    output.append(input.substring(0, input.indexOf(find)) + replace);
                    input = input.substring(input.indexOf(find) + find.length(), input.length());
                } else { return output.append(input).toString(); }
            }
        }
    }
    public static String replace(final String str, final String find, final String replace, final boolean direction) {
        String input = str;
        String search = find;
        String exchange = replace;
        StringBuilder output = new StringBuilder();
        if (direction == false) {
            input = new StringBuilder().append(input).reverse().toString();
            search = new StringBuilder().append(search).reverse().toString();
            exchange = new StringBuilder().append(exchange).reverse().toString();
        }
        if (search == "") {
            for (int i = 0; i < input.length(); ++i) { output.append(exchange + input.charAt(i)); }
            output.append(exchange);
        } else {
            while (true) {
                if (input.indexOf(search) > -1) {
                    output.append(input.substring(0, input.indexOf(search)) + exchange);
                    input = input.substring(input.indexOf(search) + search.length(), input.length());
                } else {
                    output.append(input);
                    break;
                }
            }
        }
        if (direction == false) { output.reverse(); }
        return output.toString();
    }
    public static String replace(final String str, final String find, final String replace, final int count) {
        if (count == 0) { return str; }
        String input = str;
        String search = find;
        String exchange = replace;
        int number = count;
        StringBuilder output = new StringBuilder();
        if (count < 0) {
            input = new StringBuilder().append(input).reverse().toString();
            search = new StringBuilder().append(search).reverse().toString();
            exchange = new StringBuilder().append(exchange).reverse().toString();
            number = -number;
        }
        int ocount = 0;
        if (search == "") {
            for (int i = 0; i < input.length(); ++i) {
                if (ocount < number) {
                    output.append(exchange + input.charAt(i));
                    ++ocount;
                } else { break; }
            }
            if (ocount < number) { output.append(exchange); }
            output.append(input.substring(ocount, input.length()));
        } else {
            while (true) {
                if ((input.indexOf(search)) > -1) {
                    if (ocount < number) {
                        output.append(input.substring(0, input.indexOf(search)) + exchange);
                        input = input.substring(input.indexOf(search) + search.length(), input.length());
                        ++ocount;
                    } else {
                        output.append(input);
                        break;
                    }
                } else {
                    output.append(input);
                    break;
                }
            }
        }
        if (count < 0) { output.reverse(); }
        return output.toString();
    }
}
