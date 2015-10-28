package SortArrayWIthStreamAPI;


import java.util.*;

public class SortArrayWIthStreamAPI {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        int[] nums = Arrays.asList(scr.nextLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
        String sort = scr.nextLine();
        switch (sort.toLowerCase()){
            case "ascending":
                Arrays.sort(nums);
                for (int num : nums) {
                    System.out.print(num + " ");
                }
                break;
            case "descending":
                Arrays.sort(nums);
                List<Integer> list = new ArrayList<>();
                for (int i = 0; i < nums.length; i++) {
                    list.add(nums[i]);
                }
                Collections.reverse(list);

                for (Integer integer : list) {
                    System.out.print(integer + " ");
                }
                break;
        }
    }
}
