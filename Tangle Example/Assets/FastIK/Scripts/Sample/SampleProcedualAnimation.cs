using UnityEngine;

namespace DitzelGames.FastIK
{
    class SampleProcedualAnimation :  MonoBehaviour
    {
        public Transform[] FootTarget;
        public Transform LookTarget;
        public Transform LeftHandTarget;
        public Transform RightHandTarget;


        //public Transform LeftHandPole;
        //public Transform RightHandPole;


        //public Transform Step;
        //public Transform Attraction;

        public void LateUpdate()
        {
            //move step & attraction
            //Step.Translate(Vector3.forward * Time.deltaTime * 0.7f);
            //if (Step.position.z > 1f)
                //Step.position = Step.position + Vector3.forward * -2f;
            //Attraction.Translate(Vector3.forward * Time.deltaTime * 0.5f);
            //if (Attraction.position.z > 1f)
              //Attraction.position = Attraction.position + Vector3.forward * -2f;

            //footsteps
            //for(int i = 0; i < FootTarget.Length; i++)
            //{
            //    var foot = FootTarget[i];
            //    var ray = new Ray(foot.transform.position + Vector3.up * 0.5f, Vector3.down);
            //    var hitInfo = new RaycastHit();
            //    if(Physics.SphereCast(ray, 0.05f, out hitInfo, 0.50f))
            //        foot.position = hitInfo.point + Vector3.up * 0.05f;
            //}

            //hand and look
            //var normDist = Mathf.Clamp((Vector3.Distance(LookTarget.position, Attraction.position) - 0.3f) / 1f, 0, 1);

            //LeftHandTarget.rotation = Quaternion.Lerp(Quaternion.Euler(90, 0, 0), LeftHandTarget.rotation, normDist);
            //LeftHandTarget.position = Vector3.Lerp(Attraction.position, LeftHandTarget.position, normDist);

            //RightHandTarget.rotation = Quaternion.Lerp(Quaternion.Euler(90, 0, 0), RightHandTarget.rotation, normDist);
            //RightHandTarget.position = Vector3.Lerp(Attraction.position, RightHandTarget.position, normDist);


            //LeftHandPole.position = Vector3.Lerp(LeftHandTarget.position + Vector3.down * 2, LeftHandTarget.position + Vector3.forward * 2f, normDist);
            //RightHandPole.position = Vector3.Lerp(RightHandTarget.position + Vector3.down * 2, RightHandTarget.position + Vector3.forward * 2f, normDist);

            //LookTarget.position = Vector3.Lerp(Attraction.position, LookTarget.position, normDist);


        }

    }
}
