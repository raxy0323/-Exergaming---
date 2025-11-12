# From Python
# It requires OpenCV installed for Python
# -*- coding: utf-8 -*-
import sys
import cv2
import os
import json
from sys import platform

try:
    dir_path = os.path.dirname(os.path.realpath(__file__))
    try:
        if platform == "win32":
            sys.path.append(dir_path + '/../../python/openpose/Release');
            os.environ['PATH']  = os.environ['PATH'] + ';' + dir_path + '/../../x64/Release;' +  dir_path + '/../../bin;'
            import pyopenpose as op
        else:
            sys.path.append('../../python');
            from openpose import pyopenpose as op
    except ImportError as e:
        print("Error: OpenPose library could not be found. Did you enable `BUILD_PYTHON` in CMake and have this Python script in the right folder?")
        raise e

    # 設置OP參數
    params = dict()
    params["model_folder"] = "models"   # 模型預設路徑
    params["model_pose"] = "COCO"   # 運算模型
    params["net_resolution"] = "176x256"     # 處理解析度
    params["scale_gap"] = "0.25"

    # Starting OpenPose
    opWrapper = op.WrapperPython()
    opWrapper.configure(params)
    opWrapper.start()

    # 開啓鏡頭
    cap1 = cv2.VideoCapture(0)
    cap2 = cv2.VideoCapture(1)

    # 鏡頭開啓動作
    while True:
        ret1, frame1 = cap1.read()
        ret2, frame2 = cap2.read()
        if not ret1:
            break
        if not ret2:
            break

        # Process Image
        datum1 = op.Datum()
        datum1.cvInputData = frame1
        opWrapper.emplaceAndPop(op.VectorDatum([datum1]))

        datum2 = op.Datum()
        datum2.cvInputData = frame2
        opWrapper.emplaceAndPop(op.VectorDatum([datum2]))

        output_data = dict()
        output_data["image_width"] = datum1.cvOutputData.shape[1]
        output_data["image_height"] = datum1.cvOutputData.shape[0]
        output_data["people"] = []

        for person in datum1.poseKeypoints:
            if person is not None and len(person) > 0:
                keypoints = []
                for keypoint in person:
                    keypoints.append({
                        "x": float(keypoint[0]),
                        "y": float(keypoint[1]),
                        "confidence": float(keypoint[2])
                    })
                output_data["people"].append({
                    "pose_keypoints_2d": keypoints
                })

        for person in datum2.poseKeypoints:
            if person is not None and len(person) > 0:
                keypoints = []
                for keypoint in person:
                    keypoints.append({
                        "z": float(keypoint[0]),
                        "confidence": float(keypoint[1])
                    })
                output_data["people"].append({
                    "pose_keypoints_2d": keypoints
                })

        i = 0
        output_json_path = "Json_save_path/output.json"
        with open(output_json_path, "w") as output_file:
            json.dump(output_data, output_file)

        result1 = datum1.cvOutputData
        result2 = datum2.cvOutputData

        fps = result1.get(cv2.CAP_PROP_FPS)
        cv2.putText(result1, f"FPS: {fps}", (10, 30), cv2.FONT_HERSHEY_SIMPLEX, 1, (0, 255, 0), 2)

        fps = result2.get(cv2.CAP_PROP_FPS)
        cv2.putText(result2, f"FPS: {fps}", (10, 30), cv2.FONT_HERSHEY_SIMPLEX, 1, (0, 255, 0), 2)

        # 顯示影像
        cv2.imshow("OpenPose 1.7.0 - Tutorial Python API", result1)
        if cv2.waitKey(1) & 0xFF == ord('q'):
            break

        cv2.imshow("OpenPose 1.7.0 - Tutorial Python API2", result2)
        if cv2.waitKey(1) & 0xFF == ord('q'):
            break

    # 釋放鏡頭
    cap1.release()
    cap2.release()
    cv2.destroyAllWindows()

except Exception as e:
    print(e)
    sys.exit(-1)
