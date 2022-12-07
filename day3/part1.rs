fn main() {
    let data = include_str!("puzzle_input.txt");
    let mut score = 0;
    for line in data.lines() {
        let (a, b) = line.split_at(line.chars().count() / 2);
        for c in a.chars() {
            if b.contains(c) {
                score += if c.is_uppercase() {
                    c.to_digit(36).unwrap() + 17
                } else {
                    c.to_digit(36).unwrap() - 9
                } as u32;
                break;
            }
        }
    }
    println!("{:?}", score)
}
