using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            while (start <= end)
            {
                int partitionSize = (end - start + 1) / 3;
                int mid1 = start + partitionSize;
                int mid2 = end - partitionSize;

                if (arr[mid1] == key)
                {
                    return mid1;
                }

                if (arr[mid2] == key)
                {
                    return mid2;
                }

                if (key < arr[mid1])
                {
                    end = mid1 - 1;
                }
                else if (key > arr[mid2])
                {
                    start = mid2 + 1;
                }
                else
                {
                    start = mid1 + 1;
                    end = mid2 - 1;
                }
            }

            return -1;
        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            int result = -1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (arr[mid] == key)
                {
                    result = mid;

                    if (is_first)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                else if (arr[mid] < key)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return result;
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {

            int firstIndex = BinarySearchForCalculatingRepeated(arr, key, true, 0, arr.Length - 1);
            int lastIndex = BinarySearchForCalculatingRepeated(arr, key, false, 0, arr.Length - 1);

            if (firstIndex == -1)
            {
                return 0;
            }

            return lastIndex - firstIndex + 1;
        }
    }
}
