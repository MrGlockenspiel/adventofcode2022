#!/usr/bin/perl

open my $fh, '<', 'day1.txt' or die "couldnt open file $!";
my $file_content = do { local $/; <$fh> };

my @numbers = split /\n/, $file_content;

my $current_group = 0;
my @group_sums;

foreach my $number (@numbers) {
    if ($number eq "") {
        $current_group++;
    } else {
        $group_sums[$current_group] += $number;
    }
}

@group_sums = sort { $b <=> $a } @group_sums;
$number_one = @group_sums[0];
$number_two = @group_sums[1];
$number_three = @group_sums[2];
$sum = $number_one + $number_two + $number_three;

print("Largest: $number_one\nSecond largest: $number_two\nThird largest: $number_three\n\nSum of 3 largest: $sum\n");
