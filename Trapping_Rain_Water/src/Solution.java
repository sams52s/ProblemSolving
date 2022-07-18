class Solution {
    public int trap(int[] height) {
        int result=0;
        if(height==null||height.length<=2)
            return result;

        int leftMostHeight[] = new int[height.length];
        int rightMostHeight[] = new int[height.length];

        int tempLeftMostHeight=height[0];
        leftMostHeight[0]=height[0];
        for(int i=1; i<height.length; i++)
        {
            if(height[i]<tempLeftMostHeight)
                leftMostHeight[i]=tempLeftMostHeight;
            else{
                leftMostHeight[i]=height[i];
                tempLeftMostHeight=height[i];
            }
        }

        int tempRightMostHeight=height[height.length - 1];
        rightMostHeight[height.length -1] = height[height.length - 1];
        for(int i=height.length-2; i>=0; i--)
        {
            if(height[i]<tempRightMostHeight)
                rightMostHeight[i]=tempRightMostHeight;
            else{
                rightMostHeight[i]=height[i];
                tempRightMostHeight=height[i];
            }
        }

        for(int i=0; i<height.length; i++)  {
            result += Math.min(leftMostHeight[i], rightMostHeight[i])-height[i];
        }
        return result;
    }
}