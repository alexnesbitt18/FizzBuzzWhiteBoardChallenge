public string FizzBuzz(int number)
{
        var answer = "";
            if (number % 3 == 0)
            {
                answer = "fizz";
            }
            if (number % 3 == 0)
            {
                answer = "buzz";
            }
            if (number % 3 && % 5 == 0)
            {
                answer = "fizzbuzz";
            }
            else
            {
                answer = "notfizzbuzz-able";
            }

        return answer;
}
