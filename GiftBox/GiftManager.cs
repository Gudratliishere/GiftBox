using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBox
{
    internal class GiftManager
    {
        private GiftService giftService = new();
        private List<Gift> gifts;

        public GiftManager()
        {
            gifts = giftService.ReadGifts();
        }

        public void loadGifts()
        {
            gifts = giftService.ReadGifts();
        }

        public void saveGifts()
        {
            giftService.SaveGifts(gifts);
        }

        public Gift GetGift(int custLogRef)
        {
            int count = gifts.Count;
            Random rand = new Random();
            int selectedGiftId = -1;

            while (true)
            {
                int rowNum = rand.Next(1, count + 1); // row numbers are 1-based
                var gift = gifts[rowNum - 1]; // rowNum - 1 because list is 0-based

                if (gift.Priority == 0) continue; // avoid divide by zero

                if (gift.Period % gift.Priority == 0)
                {
                    selectedGiftId = gift.Id;

                    // Update gift PERIOD
                    UpdateGiftPeriod(selectedGiftId);

                    // Insert into history
                    InsertGiftHistory(custLogRef, selectedGiftId);

                    foreach (var item in gifts)
                    {
                        System.Diagnostics.Debug.WriteLine(item.ToString());
                    }
                    System.Diagnostics.Debug.WriteLine(gift.Name + " " + gift.Period);
                    return gift;
                }
                else
                {
                    // Increase PERIOD (as in SQL loop)
                    IncrementGiftPeriod(gift.Id);
                }
            }
        }

        public void UpdateGiftPeriod(int giftId)
        {
            // UPDATE CLNT_GIFT SET PERIOD = PERIOD + 1 WHERE ID = @giftId
            for (int i = 0; i < gifts.Count; i++)
            {
                if (gifts[i].Id == giftId)
                {
                    gifts[i].Period += 1;
                }
            }
        }

        public void IncrementGiftPeriod(int giftId)
        {
            // also UPDATE CLNT_GIFT SET PERIOD = PERIOD + 1 WHERE ID = @giftId
            for (int i = 0; i < gifts.Count; i++)
            {
                if (gifts[i].Id == giftId)
                {
                    gifts[i].Period += 1;
                }
            }
        }

        public void InsertGiftHistory(int custLogRef, int giftId)
        {
            // INSERT INTO CLNT_GIFT_HISTORY
        }
    }
}
