using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StolenBreakfastDrone
{

    
    /// <summary>
    /// Your company delivers breakfast via autonomous quadcopter drones. And something mysterious has happened.
    /// 
    /// Each breakfast delivery is assigned a unique ID, a positive integer. 
    /// 
    /// When one of the company's 100 drones takes off with a delivery, the delivery's ID is added to an array, delivery_id_confirmations. 
    /// When the drone comes back and lands, the ID is again added to the same array.
    /// 
    /// After breakfast this morning there were only 99 drones on the tarmac. 
    /// One of the drones never made it back from a delivery. 
    /// We suspect a secret agent from Amazon placed an order and stole one of our patented drones. 
    /// 
    /// To track them down, we need to find their delivery ID.
    /// 
    /// Given the array of IDs, which contains many duplicate integers and one unique integer, find the unique integer.
    /// The IDs are not guaranteed to be sorted or sequential. 
    /// Orders aren't always fulfilled in the order they were received, and some deliveries get cancelled before takeoff.
    /// </summary>
    public class DeliveryManager
    {
        Drone[] _drones = new Drone[100];
        List<int> _delivery_id_confirmations = new List<int>();//can have duplicatates. a matching entry means the drone has returned.
        Dictionary<int, int> _deliveryOccurences = new Dictionary<int, int>();
        
        BitArray _deliveryConfirmations = new BitArray(100); 

        private static DeliveryManager _deliveryManager = new DeliveryManager();
        public static DeliveryManager Init()
        {
            int idStart = 9999;
            
            for (int i = 0; i < 100; i++)
            { 
                var uniqueDeliverID = idStart + i;
                BreakfastDelivery breakfast = new BreakfastDelivery(uniqueDeliverID);
                Drone drone = new Drone(_deliveryManager, breakfast);
                _deliveryManager.TakeOff(i, uniqueDeliverID);

                if (i != 68)//make 1 Drone not return
                    _deliveryManager.ReturnHome(i, uniqueDeliverID);    

                //_deliveryManager.MakeDroneNotReturn( i, uniqueDeliverID);
            }

           

            return _deliveryManager;
        }

        //private void MakeDroneNotReturn(int i, int uniqueDeliverID)
        //{
        //    if (i != 68)//make 1 Drone not return
        //        ReturnHome(uniqueDeliverID);
        //}

        private DeliveryManager()
        {
            
        }
        //public void TakeOff(int id)
        //{
        //    _delivery_id_confirmations.Add(id);
        //    _deliveryOccurences.Add(id, 1);
            
        //}
        public void TakeOff(int index, int id)
        {
            _delivery_id_confirmations.Add(id);
            _deliveryConfirmations.Set(index, false);

        }
        //public void ReturnHome(int id)
        //{
        //    _delivery_id_confirmations.Add(id);
        //    int value;
        //    if (_deliveryOccurences.TryGetValue(id, out value))
        //        _deliveryOccurences[id] = value + 1;
        //}
        public void ReturnHome(int index, int id)
        {
            _delivery_id_confirmations.Add(id);
            
            var value = _deliveryConfirmations[index];
            var xorValue = !value;
            _deliveryConfirmations.Set(index, xorValue);
        }

        public int Find()
        {
            int result = -1;
            //find matching ids i.e. duplicate ids. if an id does not have 1 an even number of matches then it has failed to return. 
            //this unmatched is it the Drone were looking for.
            
            //var uniqueIds = _delivery_id_confirmations.GroupBy(x => x).Where(x => x.Count() % 2 == 1);
            //if (uniqueIds.Count() > 0)
            //    result = uniqueIds.First().Key;

            //result = _deliveryOccurences.Where(x => x.Value % 2 == 1).Select(x => x.Key).First();

            for (int i = 0; i < _deliveryConfirmations.Count;i++ )
            {
                if (!_deliveryConfirmations[i])//if false then it hasnt returned.
                    result = _delivery_id_confirmations[i];
            }

            
            return result;
        }

    }
    public class Drone
    {
        DeliveryManager _delivery;
        BreakfastDelivery _breakfast;
        
        public Drone(DeliveryManager delivery, BreakfastDelivery breakfast)
        {
            _delivery = delivery;
            _breakfast = breakfast;
            
            //TakeOff();
        }
        //void TakeOff()
        //{
        //    _delivery.TakeOff(_breakfast.ID);
        //}
    }

    public class BreakfastDelivery
    {
        int _id;
        public BreakfastDelivery(int id)
        {
            ID = id;
        }
        public int ID
        {
            get { return _id; }
            private set
            {
                if (value <= 0)
                    throw new Exception("ID must be positive integer");
                _id = value;

            }
        }
    }


}
