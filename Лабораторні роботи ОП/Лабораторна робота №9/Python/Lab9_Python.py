# Жмайло Дмитро ІП-13, Варіант-13

def split_words(sentence: str):          # Функція для розділення речення на окремі слова
    separated_words = []
    separated_words = sentence.split()
    return separated_words

def find_words(words_arr, first, last):         # Функція для пошуку слів за заданими літерами
    words_res = []
    for i in range(len(words_arr)):
        temp_word = words_arr[i]
        temp_first = temp_word[0]
        temp_last = temp_word[-1]
        if ( (temp_first == first) and (temp_last == last) ):
            words_res.append(temp_word)
    return words_res

def display_arr(array: str):         # Функція, яка поелементно виводить масив результату у консоль
    for i in range (len(array)):
        print(array[i])


text = str(input('Input your sentence: '))
words_arr = split_words(text)
first_letter = str(input('Input first letter: '))
last_letter = str(input('Input last letter: '))
result_array = find_words(words_arr, first_letter, last_letter)
print(f'All words, that starts with letter \'{first_letter}\' and finishes with letter \'{last_letter}\': ')
display_arr(result_array)

