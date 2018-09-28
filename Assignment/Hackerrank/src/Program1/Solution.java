package Program1;

public class Solution {
	static String mergeStrings(String a, String b) {
		String c = "";
		int l1 = a.length();
		int l2 = b.length();
		int len = l1 + l2;
		int min;
		if (l1 < l2) {
			min = l1;
		} else {
			min = l2;
		}
		int max;
		if (l1 > l2) {
			max = l1;
		} else {
			max = l2;
		}
		int j = 0;
		for (int i = 0; i < min; i++) {
			c = c + a.charAt(i);
			c = c + b.charAt(j);
			j++;
		}
		if (l1 == max) {
			for (int i = min; i < max; i++) {
				c = c + a.charAt(i);
			}
		} else {
			for (int i = min; i < max; i++) {
				c = c + b.charAt(i);
			}
		}
		return c;

	}

}
